using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AME.UI.Win.Models;
using AME.UI.Win.Views;

namespace AME.UI.Win.Presenters
{
    /// <summary>
    /// Base class for all presenter classes. Keeps track of Model and View classes.
    /// Notice that Model is static and View is set in the constructor.
    /// </summary>
    /// <remarks>
    /// MV Patterns: MVP design pattern.
    /// </remarks>
    /// <typeparam name="T">Type of view.</typeparam>
    public class Presenter<T> where T : IView
    {
        protected static IModel Model { get; private set; }

        static Presenter()
        {
            Model = new Model();
        }

        public Presenter(T view)
        {
            View = view;
        }

        protected T View { get; private set; }
    }
}

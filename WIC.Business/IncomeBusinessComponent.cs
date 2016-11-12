using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WIC.Entities;

namespace WIC.Business
{
    public class IncomeBusinessComponent
    {

        /// <summary>
        /// Apply WIC Income Eligibility Guidelines.  The adjusted income eligibility guidelines are used by State agencies 
        /// in determining the income eligibility of persons applying to participate in the WIC Program. 
        /// </summary>
        /// <param name="member">The applicant member.</param>
        /// <returns>Returns a Member object.</returns>
        /// <seealso cref="http://www.fns.usda.gov/wic/wic-income-eligibility-guidelines"/>
        /// <remarks>http://www.dofactory.com/net/facade-design-pattern</remarks>
        public bool IsEligible(Member member, int amount)
        {
            //private Category category = new Category();
            //private Residential residential = new Residential();
            //private Income income = new Income();
            //private Risk risk = new Risk();
            // http://www.health.state.mn.us/wic/localagency/training/nutrition/nst/riskcodes.pdf
            // http://www.fns.usda.gov/sites/default/files/WICDietaryRisk.pdf
            // http://www.health.state.mn.us/divs/fh/wic/localagency/nutrition/riskcodes/anthro/index.html
            // http://www.floridahealth.gov/programs-and-services/wic/wic-program-info.html
            // http://www.fns.usda.gov/sites/default/files/wic/WIC-IEGS-WEB-185-16-17.pdf

            bool eligible = false;
            // Ascertain eligibility of applicant.
            //foreach (Applicant applicant in Member)
            //{ 
            //    if (!_bank.HasSufficientSavings(cust, amount))
            //    {
            //        eligible = false;
            //    }
            //    else if (residential.IsLocal(applicant))
            //    {
            //        eligible = false;
            //    }
            //    else if (income.HasIncomeEligibility(applicant))
            //    {
            //        eligible = false;
            //    }
            //    else if (risk.HasRisks(applicant))
            //    {
            //        eligible = true;
            //    }
            return eligible;
            //}         
        }
    }
}

using WIC.Entities;

namespace WIC.Data
{
    public interface IMemberDAC
    {
        void InsertMember(Member member);
        void UpdateMember(Member member);
    }
}
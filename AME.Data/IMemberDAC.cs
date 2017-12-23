using AME.Entities;

namespace AME.Data
{
    public interface IMemberDAC
    {
        void InsertMember(Member member);
        void UpdateMember(Member member);
    }
}
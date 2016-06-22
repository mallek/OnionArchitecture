using System.Collections.Generic;

namespace OnionArchitecture.Core.Interfaces
{
    public interface IBloodDonorRepository
    {
        void Add(BloodDonor b);
        void Edit(BloodDonor b);
        void Remove(string BloodDonorID);
        IEnumerable<BloodDonor> GetBloodDonors();
        BloodDonor FindById(string BloodDonorID);

    }
}

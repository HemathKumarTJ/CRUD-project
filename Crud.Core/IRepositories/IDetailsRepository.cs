using Crud.Core.Model;
using Crud.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Core.IRepositories
{
    public interface IDetailsRepository
    {
        void CreateDetails(Details details);
        List<Details> ListMethod();

        Details SaveMethod(int id);

        void Update(int id, Details details);

        void DeleteDone(int id);

    }
}

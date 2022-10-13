using Crud.Core.IRepositories;
using Crud.Core.Model;
using Crud.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Repositories.Repositories
{
    
    public class DetailsRepository : IDetailsRepository
    {
        private readonly CrudProjectContext _crudprojectcontext;

        public DetailsRepository(CrudProjectContext crudprojectcontext)
        {
            _crudprojectcontext = crudprojectcontext;
        }

        #region Create
        public void  CreateDetails(Details details)
        {
           
                StuDetails studetails = new StuDetails();
                studetails.First_Name = details.FirstName;
                studetails.Middle_Name = details.MiddleName;
                studetails.Last_Name = details.LastName;
                studetails.Course = details.Course;
                studetails.Gender = details.Gender;
                studetails.Phone = details.Phone;
                studetails.Address = details.Address;
                studetails.Email = details.Email;
                studetails.Password = details.Password;
                studetails.ReType_Password = details.ReTypePassword;
                studetails.Created_Time_Stamp = DateTime.Now;
                studetails.Updated_Time_Stamp = DateTime.Now;
                _crudprojectcontext.Add(studetails);
                _crudprojectcontext.SaveChanges();
            

        }
        #endregion

        #region Read
        public List<Details> ListMethod()
        {
            List<Details> model = new List<Details>();
            var data = _crudprojectcontext.StuDetails.Where(a=> a.Is_Deleted == false).ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    Details details = new Details();
                    details.id = item.id;
                    details.FirstName = item.First_Name;
                    details.MiddleName = item.Middle_Name;
                    details.LastName = item.Last_Name;
                    details.Course = item.Course;
                    details.Gender = item.Gender;
                    details.Phone = item.Phone;
                    details.Address = item.Address;
                    details.Email = item.Email;
                    details.Password = item.Password;
                    details.ReTypePassword = item.ReType_Password;
                    model.Add(details);

                }
            }

            return model;

        }
        #endregion

        #region Update
        public Details SaveMethod(int id)
        {

            Details details = new Details();
            var item = _crudprojectcontext.StuDetails.Where(a => a.id == id).SingleOrDefault();
           
                details.id = item.id;
                details.FirstName = item.First_Name;
                details.MiddleName = item.Middle_Name;
                details.LastName = item.Last_Name;
                details.Course = item.Course;
                details.Gender = item.Gender;
                details.Phone = item.Phone;
                details.Address = item.Address;
                details.Email = item.Email;
                details.Password = item.Password;
                details.ReTypePassword = item.ReType_Password;
                return details;
            
        }
        public void Update(int id, Details details)
        {
            var data = _crudprojectcontext.StuDetails.Where(a => a.id == id).SingleOrDefault();
            if (data != null)
            {
                data.First_Name = details.FirstName;
                data.Middle_Name= details.MiddleName;
                data.Last_Name= details.LastName;
                data.Course = details.Course;
                data.Gender = details.Gender;
                data.Phone = details.Phone;
                data.Address = details.Address;
                data.Email = details.Email;
                data.Password = details.Password;
                data.ReType_Password = details.ReTypePassword;
                _crudprojectcontext.SaveChanges();  
            }
        }
        #endregion

        #region Delete
        public void DeleteDone(int id)
        {
            var data = _crudprojectcontext.StuDetails.Where(a => a.id == id).SingleOrDefault();
            if (data != null)
            {

                data.Is_Deleted = true;
                _crudprojectcontext.SaveChanges();
            }
        }
        #endregion



    }
}

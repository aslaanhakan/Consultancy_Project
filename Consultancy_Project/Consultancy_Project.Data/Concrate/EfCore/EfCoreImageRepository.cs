using Consultancy_Project.Data.Abstract;
using Consultancy_Project.Data.Concrate.EfCore.Context;
using Consultancy_Project.Entity.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Data.Concrate.EfCore
{
    public class EfCoreImageRepository : EfCoreGenericRepository<Image>, IImageRepository
    {
        public EfCoreImageRepository(ConsultancyProjectContext _appContext) : base(_appContext)
        {
        }
        ConsultancyProjectContext AppContext
        {
            get { return _dbContext as ConsultancyProjectContext; }
        }

        public void UpdateImage(Image image)
        {
            var result = AppContext.Images.Where(x => x.UserId == image.UserId).FirstOrDefault();

            result.Url = image.Url;
            result.UpdatedTime = image.UpdatedTime;
            result.UserId= image.UserId;
            AppContext.Update(result);
            AppContext.SaveChanges();
        }
    }
}

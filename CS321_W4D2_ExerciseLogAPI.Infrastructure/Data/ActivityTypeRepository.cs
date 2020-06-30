using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS321_W4D2_ExerciseLogAPI.Core.Models;
using CS321_W4D2_ExerciseLogAPI.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{
    public class ActivityTypeRepository : IActivityTypeRepository
    {
        private readonly AppDbContext _dbContext;

        public ActivityTypeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ActivityType Add(ActivityType activityType)
        {
            _dbContext.Add(activityType);
            _dbContext.SaveChanges();
            return activityType;
        }

        public ActivityType Get(int id)
        {
            return _dbContext.ActivityTypes.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<ActivityType> GetAll()
        {
            return _dbContext.ActivityTypes;
        }

        public void Remove(ActivityType deleteActivity)
        {
            _dbContext.ActivityTypes.Remove(deleteActivity);
            _dbContext.SaveChanges();
        }

        public ActivityType Update(ActivityType updateActivity)
        {
            var currentActivity = _dbContext.ActivityTypes.Find(updateActivity.Id);
            if (currentActivity == null) return null;

            _dbContext.Entry(currentActivity)
                .CurrentValues
                .SetValues(updateActivity);

            _dbContext.ActivityTypes.Update(currentActivity);
            _dbContext.SaveChanges();
            return currentActivity;
        }
    }
}

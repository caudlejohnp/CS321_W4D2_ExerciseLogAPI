using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS321_W4D2_ExerciseLogAPI.Core.Models;
using CS321_W4D2_ExerciseLogAPI.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{
    public class ActivityRepository : IActivityRepository
    {
        //TODO: on get and get all include activityType and User
        private readonly AppDbContext _dbContext;

        public ActivityRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Activity Add(Activity activity)
        {
            _dbContext.Add(activity);
            _dbContext.SaveChanges();
            return activity;
        }

        public Activity Get(int id)
        {
            return _dbContext.Activities.Include(a => a.ActivityType).FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Activity> GetAll()
        {
            return _dbContext.Activities.Include(a => a.ActivityType);
        }

        public void Remove(Activity deleteActivity)
        {
            _dbContext.Activities.Remove(deleteActivity);
            _dbContext.SaveChanges();
        }

        public Activity Update(Activity updateActivity)
        {
            var currentActivity = _dbContext.Activities.Find(updateActivity.Id);
            if (currentActivity == null) return null;

            _dbContext.Entry(currentActivity)
                .CurrentValues
                .SetValues(updateActivity);

            _dbContext.Activities.Update(currentActivity);
            _dbContext.SaveChanges();
            return currentActivity;
        }
    }
}

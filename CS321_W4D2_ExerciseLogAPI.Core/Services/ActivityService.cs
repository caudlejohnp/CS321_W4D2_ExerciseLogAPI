using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public class ActivityService : IActivityService
    {
        private IActivityRepository _activity;

        public ActivityService(IActivityRepository activity)
        {
            _activity = activity;
        }

        public Activity Add(Activity activity)
        {
            _activity.Add(activity);
            return activity;
        }

        public Activity Get(int id)
        {
            return _activity.Get(id);
        }

        public IEnumerable<Activity> GetAll()
        {
            return _activity.GetAll();
        }

        public Activity Update(Activity updatedActivity)
        {
            var activity = _activity.Update(updatedActivity);
            return activity;
        }

        public void Remove(Activity activity)
        {
            _activity.Remove(activity);
        }
    }
}

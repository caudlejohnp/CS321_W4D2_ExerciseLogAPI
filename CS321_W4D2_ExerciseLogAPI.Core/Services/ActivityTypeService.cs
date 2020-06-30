using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public class ActivityTypeService : IActivityTypeService
    {
        private IActivityTypeRepository _activityRepo;

        public ActivityTypeService(IActivityTypeRepository activityRepo)
        {
            _activityRepo = activityRepo;
        }

        public ActivityType Add(ActivityType activityType)
        {
            _activityRepo.Add(activityType);
            return activityType;
        }

        public ActivityType Get(int id)
        {
            return _activityRepo.Get(id);
        }

        public IEnumerable<ActivityType> GetAll()
        {
            return _activityRepo.GetAll();
        }

        public ActivityType Update(ActivityType updatedActivity)
        {
            var activity = _activityRepo.Update(updatedActivity);
            return activity;
        }

        public void Remove(ActivityType activity)
        {
            _activityRepo.Remove(activity);
        }
    }
}

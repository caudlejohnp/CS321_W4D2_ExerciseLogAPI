using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public interface IActivityTypeRepository
    {
        //Create
        ActivityType Add(ActivityType activityType);

        //Read
        ActivityType Get(int id);

        //Update
        ActivityType Update(ActivityType updateActivity);

        //Delete
        void Remove(ActivityType deleteActivity);

        //List
        IEnumerable<ActivityType> GetAll();
    }
}

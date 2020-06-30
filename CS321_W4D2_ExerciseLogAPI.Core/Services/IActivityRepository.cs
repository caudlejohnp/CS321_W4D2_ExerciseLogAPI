﻿using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public interface IActivityRepository
    {

        //Create
        Activity Add(Activity activity);

        //Read
        Activity Get(int id);

        //Update
        Activity Update(Activity updateActivity);

        //Delete
        void Remove(Activity deleteActivity);

        //List
        IEnumerable<Activity> GetAll();
    }
}

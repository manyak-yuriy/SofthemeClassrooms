﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ScheduleController : Controller
    {
        // Render the page
        public ActionResult Index()
        {
            return new EmptyResult();
        }

        // Get data about events for a specific date
        public ActionResult GetSchedulerState(DateTime date)
        {
            return new EmptyResult();
        }

        // Get equipment info for a specific room
        public ActionResult GetRoomInfo(int roomId)
        {
            return new EmptyResult();
        }
    }
}
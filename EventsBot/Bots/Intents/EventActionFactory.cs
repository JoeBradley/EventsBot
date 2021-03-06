﻿using EventsBot.Models;
using System;

namespace EventsBot.Bots
{
    public class EventActionFactory {
        public static IBotAction Create(DialogFlowResult result, CompanyEvent companyEvent) {
            switch (result.action.ToLower()) {
                case "event.dates":
                    return new EventDatesAction(companyEvent, result.parameters["date-type"]);

                case "event.location":
                    return new EventLocationAction(companyEvent, result.parameters["place-type"]);
                    
                case "event.registration.costs":
                    return new EventCostsAction(companyEvent);

                case "event.registration.dates":
                    return new EventRegistrationAction(companyEvent, result.parameters["Event-Dates"]);

                default:
                    throw new Exception();
            }
        }
    }
}
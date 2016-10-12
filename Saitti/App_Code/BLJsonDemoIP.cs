using System;

namespace JAMK.IT
{
    public class Person
    {
        public string Name { get; set; }

        public string Gender { get; set; }

        public string Birthday { get; set; }

        public Person()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
    public class Politician : Person
    {
        public string Party { get; set; }
        public string Position { get; set; }
    }

    public class Timetable
    {
        public string stationShortCode { get; set; }
        public int stationUICCode { get; set; }
        public string countryCode { get; set; }
        public string type { get; set; }
        public Boolean trainStopping { get; set; }
        public Boolean commercialStop { get; set; }
        public string commercialTrack { get; set; }
        public Boolean cancelled { get; set; }
        public string scheduledTime { get; set; }
        public string actualTime { get; set; }
        public int differenceInMinutes { get; set; }
        //*      "causes":[]

        public Timetable()
        {

        }
    }

    public class Train
    {
        /*
         * [{
         * "trainNumber":8,
         * "departureDate":"2016-10-12",
         * "operatorUICCode":10,
         * "operatorShortCode":"vr",
         * "trainType":"IC",
         * "trainCategory":"Long-distance",
         * "commuterLineID":"",
         * "runningCurrently":true,
         * "cancelled":false,
         * "version":144180804505,
         * "timeTableRows":[{
         *      "stationShortCode":"JNS",
         *      "stationUICCode":460,
         *      "countryCode":"FI",
         *      "type":"DEPARTURE",
         *      "trainStopping":true,
         *      "commercialStop":true,
         *      "commercialTrack":"3",
         *      "cancelled":false,
         *      "scheduledTime":"2016-10-12T09:17:00.000Z",
         *      "actualTime":"2016-10-12T09:17:35.000Z",
         *      "differenceInMinutes":1,
         *      "causes":[]},
         * 
         */
        public int trainNumber { get; set; }
        public string departureDate { get; set; }
        public int operatorUICCode { get; set; }
        public string operatorShorCode { get; set; }
        public string trainType { get; set; }
        public string trainCategory { get; set; }
        public string commuterLineID { get; set; }
        public Boolean runningCurrently { get; set; }
        public Boolean cancelled { get; set; }
        public long version { get; set; }
        public Timetable[] timeTableRows { get; set; }

        public Train()
        {

        }

    }
    public class Station
    {
        /*{
         * "passengerTraffic":false,
         * "type":"STATION",
         * "stationName":"Ahonpää",
         * "stationShortCode":"AHO",
         * "stationUICCode":1343,
         * "countryCode":"FI",
         * "longitude":25.01206612315972,
         * "latitude":64.55181651445501},*/
        public Boolean passengerTraffic { get; set; }
        public string type { get; set; }
        public string stationName { get; set; }
        public string stationShortCode { get; set; }
        public long stationUICCode {get;set;}
        public string countryCode { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }

        public Station()
        {

        }

    }
}
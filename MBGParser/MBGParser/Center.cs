﻿using System.Collections.Generic;

namespace MBGParser
{
    public struct Center
    {
        public Position<double> Position;
        public Motion<double> Motion;

        public List<Event.Event> Events;

        internal static Center? ParseFromContent(string content)
        {
            if (content == "False")
                return null;
            else
            {
                Center center;

                center.Position.X = double.Parse(Utils.ReadString(ref content));
                center.Position.Y = double.Parse(Utils.ReadString(ref content));

                center.Motion.Speed = double.Parse(Utils.ReadString(ref content));
                center.Motion.SpeedDirection = double.Parse(Utils.ReadString(ref content));

                center.Motion.Acceleration = double.Parse(Utils.ReadString(ref content));
                center.Motion.AccelerationDirection = double.Parse(Utils.ReadString(ref content));

                center.Events = null;
                if (content != string.Empty)
                    center.Events = Event.Event.ParseEvents(Utils.ReadString(ref content));

                return center;
            }
        }
    }
}
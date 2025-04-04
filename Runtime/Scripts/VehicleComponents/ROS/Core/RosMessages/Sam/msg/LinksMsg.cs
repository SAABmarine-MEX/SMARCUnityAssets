//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Sam
{
    [Serializable]
    public class LinksMsg : Message
    {
        public const string k_RosMessageName = "sam_msgs/Links";
        public override string RosMessageName => k_RosMessageName;

        // 
        //  SAM links
        // 
        public const string BASE_LINK = "'base_link'";
        public const string BASE_LINK_2D = "'base_link_2d'";
        public const string PRESS_LINK = "'pressure_link'";
        public const string GPS_LINK = "'gps_link'";
        public const string DVL_LINK = "'dvl_link'";
        public const string IMU_LINK = "'imu_link'";
        public const string ODOM_LINK = "'odom'";
        public const string SBG_LINK = "'sbg_link'";

        public LinksMsg()
        {
        }
        public static LinksMsg Deserialize(MessageDeserializer deserializer) => new LinksMsg(deserializer);

        private LinksMsg(MessageDeserializer deserializer)
        {
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
        }

        public override string ToString()
        {
            return "LinksMsg: ";
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}

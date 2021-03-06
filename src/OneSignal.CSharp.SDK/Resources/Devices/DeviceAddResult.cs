﻿using RestSharp.Deserializers;

namespace OneSignal.CSharp.SDK.Resources.Devices
{
    public class DeviceAddResult
    {
        [DeserializeAs(Name = "success")]
        public bool IsSuccess { get; set; }

        [DeserializeAs(Name = "id")]
        public string Id { get; set; }
    }
}

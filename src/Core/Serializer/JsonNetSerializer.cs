﻿using System.Text;
using Newtonsoft.Json;

namespace Foundatio.Serializer {
    public class JsonNetSerializer : ISerializer {
        protected readonly JsonSerializerSettings _settings;

        public JsonNetSerializer(JsonSerializerSettings settings = null) {
            _settings = settings ?? new JsonSerializerSettings();
        }

        public T Deserialize<T>(byte[] value) {
            return JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(value), _settings);
        }

        public byte[] Serialize(object value) {
            return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(value, _settings));
        }
    }
}

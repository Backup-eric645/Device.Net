﻿using Device.Net;
using System;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class MockDevice : DeviceBase, IDevice
    {
        private bool _IsInitialized;

        public override ushort WriteBufferSize => 64;

        public override ushort ReadBufferSize => 64;

        public override bool IsInitialized => _IsInitialized;

        public void Close()
        {
            throw new NotImplementedException();
        }

        public Task InitializeAsync()
        {
            _IsInitialized = true;
            return Task.FromResult(true);
        }

        public override Task<byte[]> ReadAsync()
        {
            return Task.FromResult(new byte[64] { 1, 2, 3, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        }

        public override Task WriteAsync(byte[] data)
        {
            return Task.FromResult(true);
        }
    }
}

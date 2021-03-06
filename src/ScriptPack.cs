﻿using ScriptCs.Contracts;

namespace ScriptCs.MpnsTester
{
    public class ScriptPack : IScriptPack
    {
        private NotificationManager _notificationManager;

        IScriptPackContext IScriptPack.GetContext()
        {
            if (_notificationManager == null)
            {
                _notificationManager = new NotificationManager();
            }

            return _notificationManager;
        }

        void IScriptPack.Initialize(IScriptPackSession session)
        {
      
        }

        public void Terminate()
        {

        }
    }
}
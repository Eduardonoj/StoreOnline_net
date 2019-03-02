using System;

namespace StoreOnline.App.Interfaces
{
    public interface IVisualizable
    {
        DateTime StartToSee(DateTime dateI);

        void StopToSee(DateTime dateI, DateTime dateF);
    }
}
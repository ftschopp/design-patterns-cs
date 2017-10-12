using System;

namespace Flyweight
{
    public interface IGeometry
    {
        // intrinsic state
        void GetShape();
        // extrinsic state
        void GetColor(int size);
    }    
}
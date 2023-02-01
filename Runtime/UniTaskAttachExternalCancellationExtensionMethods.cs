using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Kogane
{
    public static class UniTaskAttachExternalCancellationExtensionMethods
    {
        public static UniTask AttachExternalCancellation
        (
            this UniTask self,
            GameObject   gameObject
        )
        {
            if ( gameObject == null ) throw new OperationCanceledException();

            return self.AttachExternalCancellation( gameObject.GetCancellationTokenOnDestroy() );
        }

        public static UniTask<T> AttachExternalCancellation<T>
        (
            this UniTask<T> self,
            GameObject      gameObject
        )
        {
            if ( gameObject == null ) throw new OperationCanceledException();

            return self.AttachExternalCancellation( gameObject.GetCancellationTokenOnDestroy() );
        }

        public static UniTask AttachExternalCancellation<TComponent>
        (
            this UniTask self,
            TComponent   component
        ) where TComponent : Component
        {
            if ( component == null ) throw new OperationCanceledException();

            return self.AttachExternalCancellation( component.GetCancellationTokenOnDestroy() );
        }

        public static UniTask<T> AttachExternalCancellation<T, TComponent>
        (
            this UniTask<T> self,
            TComponent      component
        ) where TComponent : Component
        {
            if ( component == null ) throw new OperationCanceledException();

            return self.AttachExternalCancellation( component.GetCancellationTokenOnDestroy() );
        }
    }
}
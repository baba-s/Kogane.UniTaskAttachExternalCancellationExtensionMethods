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
            return self.AttachExternalCancellation( gameObject.GetCancellationTokenOnDestroy() );
        }

        public static UniTask<T> AttachExternalCancellation<T>
        (
            this UniTask<T> self,
            GameObject      gameObject
        )
        {
            return self.AttachExternalCancellation( gameObject.GetCancellationTokenOnDestroy() );
        }

        public static UniTask AttachExternalCancellation<TComponent>
        (
            this UniTask self,
            TComponent   component
        ) where TComponent : Component
        {
            return self.AttachExternalCancellation( component.GetCancellationTokenOnDestroy() );
        }

        public static UniTask<T> AttachExternalCancellation<T, TComponent>
        (
            this UniTask<T> self,
            TComponent      component
        ) where TComponent : Component
        {
            return self.AttachExternalCancellation( component.GetCancellationTokenOnDestroy() );
        }
    }
}
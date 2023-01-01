# Kogane UniTask Attach External Cancellation Extension Methods

AttachExternalCancellation の引数に GameObject や Component を渡せるようにする拡張メソッド

## 使用例

```cs
using Cysharp.Threading.Tasks;
using Kogane;
using UnityEngine;

public sealed class Example : MonoBehaviour
{
    private async UniTaskVoid Star()
    {
        UniTask       Impl1() => UniTask.CompletedTask;
        UniTask<bool> Impl2() => UniTask.FromResult( true );

        await Impl1().AttachExternalCancellation( gameObject );
        await Impl1().AttachExternalCancellation( this );
        _ = await Impl2().AttachExternalCancellation( gameObject );
        _ = await Impl2().AttachExternalCancellation( this );
    }
}
```
using NUnit.Framework;
using UnityEditor;

namespace Kogane.Internal
{
	internal sealed class MissingPrefabInstanceTest
	{
		[Category( nameof( Kogane ) )]
		[Test]
		public void Missing_Prefab_になっているゲームオブジェクトが存在しない()
		{
			AllGameObjectTester.Test( gameObject => PrefabUtility.GetPrefabInstanceStatus( gameObject ) != PrefabInstanceStatus.MissingAsset );
		}
	}
}
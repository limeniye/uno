using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace Microsoft.UI.Composition;

public partial class Vector3KeyFrameAnimation : KeyFrameAnimation
{
	private readonly SortedDictionary<float, Vector3> _keyFrames = new();

	internal Vector3KeyFrameAnimation(Compositor compositor) : base(compositor)
	{
	}

	private protected override int KeyFrameCountCore => _keyFrames.Count;

	public void InsertKeyFrame(float normalizedProgressKey, Vector3 value)
		=> _keyFrames[normalizedProgressKey] = value;

	internal override object Start()
	{
		base.Start();
		if (!_keyFrames.TryGetValue(0, out var startValue))
		{
			// TODO: Set startValue to be the current property value.
		}

		_keyframeEvaluator = new KeyFrameEvaluator<Vector3>(startValue, _keyFrames[1.0f], Duration, _keyFrames, Vector3.Lerp, IterationCount, IterationBehavior, Compositor);
		return startValue;
	}
}

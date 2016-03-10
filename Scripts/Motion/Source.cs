﻿using UnityEngine;
using System;
using System.Collections.Generic;

namespace UrMotion
{
	public static class Source
	{
		public static float DefaultFrameRate = 60f;

		public static void ValidateFrameRate(ref float fps)
		{
			if (fps == 0f) {
				fps = DefaultFrameRate;
			}
		}

		public static IEnumerator<V> Constant<V>(V val)
		{
			for (;;) {
				yield return val;
			}
		}

		public static IEnumerator<V> Function<V>(Func<V> f)
		{
			for (;;) {
				yield return f();
			}
		}

		public static IEnumerator<float> Sin(IEnumerator<float> radius, float freq, float fps = 0f)
		{
			ValidateFrameRate(ref fps);
			var f = 0f;
			while (radius.MoveNext()) {
				yield return Mathf.Sin((f / fps) * Mathf.PI * 2f * freq) * radius.Current;
				f += 1.0f;
			}
		}

		public static IEnumerator<Vector2> Sin(IEnumerator<Vector2> radius, float freq, float fps = 0f)
		{
			ValidateFrameRate(ref fps);
			var f = 0f;
			while (radius.MoveNext()) {
				yield return Mathf.Sin((f / fps) * Mathf.PI * 2f * freq) * radius.Current;
				f += 1.0f;
			}
		}

		public static IEnumerator<Vector3> Sin(IEnumerator<Vector3> radius, float freq, float fps = 0f)
		{
			ValidateFrameRate(ref fps);
			var f = 0f;
			while (radius.MoveNext()) {
				yield return Mathf.Sin((f / fps) * Mathf.PI * 2f * freq) * radius.Current;
				f += 1.0f;
			}
		}

		public static IEnumerator<Vector4> Sin(IEnumerator<Vector4> radius, float freq, float fps = 0f)
		{
			ValidateFrameRate(ref fps);
			var f = 0f;
			while (radius.MoveNext()) {
				yield return Mathf.Sin((f / fps) * Mathf.PI * 2f * freq) * radius.Current;
				f += 1.0f;
			}
		}

		public static IEnumerator<float> Cos(IEnumerator<float> radius, float freq, float fps = 0f)
		{
			ValidateFrameRate(ref fps);
			var f = 0f;
			while (radius.MoveNext()) {
				yield return Mathf.Cos((f / fps) * Mathf.PI * 2f * freq) * radius.Current;
				f += 1.0f;
			}
		}

		public static IEnumerator<Vector2> Cos(IEnumerator<Vector2> radius, float freq, float fps = 0f)
		{
			ValidateFrameRate(ref fps);
			var f = 0f;
			while (radius.MoveNext()) {
				yield return Mathf.Cos((f / fps) * Mathf.PI * 2f * freq) * radius.Current;
				f += 1.0f;
			}
		}

		public static IEnumerator<Vector3> Cos(IEnumerator<Vector3> radius, float freq, float fps = 0f)
		{
			ValidateFrameRate(ref fps);
			var f = 0f;
			while (radius.MoveNext()) {
				yield return Mathf.Cos((f / fps) * Mathf.PI * 2f * freq) * radius.Current;
				f += 1.0f;
			}
		}

		public static IEnumerator<Vector4> Cos(IEnumerator<Vector4> radius, float freq, float fps = 0f)
		{
			ValidateFrameRate(ref fps);
			var f = 0f;
			while (radius.MoveNext()) {
				yield return Mathf.Cos((f / fps) * Mathf.PI * 2f * freq) * radius.Current;
				f += 1.0f;
			}
		}
	}
}
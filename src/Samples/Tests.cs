﻿using Samples.Helpers;
using WebGLDotNET;

namespace Samples
{
    public static class Tests
    {
        private static WebGL2RenderingContext gl;

        public static void Run()
        {
            using (var canvas = HtmlHelper.AddCanvas("tests-canvas-wrapper", "tests-canvas", 1, 1))
            {
                gl = new WebGL2RenderingContext(canvas);

                GetErrorRegression();
            }
        }

        // https://github.com/WaveEngine/WebGL.NET/issues/5
        private static void GetErrorRegression()
        {
            gl.GetError();
        }
    }
}
﻿using BenchmarkDotNet.Running;

namespace FastExpressionCompiler.Benchmarks
{
    
    public class Program
    {
        public static void Main()
        {
            //BenchmarkRunner.Run<ArrayCopy_vs_ManualForLoop>();

            //var a = new NestedLambdasVsVars();
            //a.Init();
            //a.Expression_with_sub_expressions_CompiledFast();
            //BenchmarkRunner.Run<NestedLambdasVsVars>();

            //BenchmarkRunner.Run<AutoMapper_UseCase_Simplified_OneProperty.Compile_only>();
            //BenchmarkRunner.Run<AutoMapper_UseCase_Simplified_OneProperty.Create_and_Compile>();
            //BenchmarkRunner.Run<AutoMapper_UseCase_Simplified_OneProperty.Invoke_compiled_delegate>();

            //BenchmarkRunner.Run<NestedLambdaOverhead>();

            //BenchmarkRunner.Run<FEC_vs_ManualEmit_vs_Activator>();

            //BenchmarkRunner.Run<MultipleNestedLambdaExprVsExprSharing>();

            //BenchmarkRunner.Run<ObjectExecutor_SyncMethod_Compile>();
            //BenchmarkRunner.Run<ObjectExecutor_SyncMethod_Execute>();

            //BenchmarkRunner.Run<ObjectExecutor_AsyncMethod_CreateExecutor>();
            //BenchmarkRunner.Run<ObjectExecutor_AsyncMethod_ExecuteAsync>();
            //BenchmarkRunner.Run<ObjectExecutor_AsyncMethod_Execute>();
            //BenchmarkRunner.Run<StaticTypeOfSwitch>();

            //BenchmarkRunner.Run<ExprInfoVsExpr_TryCatchExpr.Compilation>();
            //BenchmarkRunner.Run<ExprInfoVsExpr_TryCatchExpr.Invocation>();

            //BenchmarkRunner.Run<SimpleExpr_ParamPlusParam>();

            //BenchmarkRunner.Run<LightExprVsExpr_Create_ComplexExpr>();
            //BenchmarkRunner.Run<LightExprVsExpr_CreateAndCompile_ComplexExpr>();
            //BenchmarkRunner.Run<LightExprVsExpr_CreateAndCompile_NestedLambdaExpr>();
            //BenchmarkRunner.Run<LightExprVsExpr_CreateAndCompile_SimpleExpr>();

            //BenchmarkRunner.Run<HoistedLambdaBenchmark.Compilation>();
            //BenchmarkRunner.Run<HoistedLambdaBenchmark.Invocation>();

            //BenchmarkRunner.Run<HoistedLambdaWithNestedLambdaBenchmark.Compilation>();
            BenchmarkRunner.Run<HoistedLambdaWithNestedLambdaBenchmark.Invocation>();

            //BenchmarkRunner.Run<HoistedLambdaBenchmark_LogicalOps.Invoke>();
            //BenchmarkRunner.Run<HoistedLambdaBenchmark_LogicalOps.Compile>();
            //BenchmarkRunner.Run<HoistedLambdaBenchmark.Invoke>();

            //BenchmarkRunner.Run<ManuallyComposedLambdaBenchmark.Compilation>();
            //BenchmarkRunner.Run<ManuallyComposedLambdaBenchmark.Invocation>();
        }
    }
}

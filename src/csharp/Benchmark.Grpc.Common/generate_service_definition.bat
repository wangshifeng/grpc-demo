cd /d %~dp0
..\packages\Google.Protobuf.3.0.0-alpha4\tools\protoc.exe -I..\..\protos --csharp_out .\ --grpc_out .\ --plugin=protoc-gen-grpc=..\packages\Grpc.Tools.0.12.0\tools\grpc_csharp_plugin.exe ..\..\protos\BenchmarkService.proto
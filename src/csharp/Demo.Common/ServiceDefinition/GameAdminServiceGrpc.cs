// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: GameAdminService.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Demo.Common.ServiceDefinition {
  public static class GameAdminService
  {
    static readonly string __ServiceName = "demo.GameAdminService";

    static readonly Marshaller<global::Demo.Common.ServiceDefinition.AccountRequest> __Marshaller_AccountRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Demo.Common.ServiceDefinition.AccountRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Demo.Common.ServiceDefinition.Account> __Marshaller_Account = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Demo.Common.ServiceDefinition.Account.Parser.ParseFrom);
    static readonly Marshaller<global::Demo.Common.ServiceDefinition.ChatMessageRequest> __Marshaller_ChatMessageRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Demo.Common.ServiceDefinition.ChatMessageRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Demo.Common.ServiceDefinition.ChatMessageCollection> __Marshaller_ChatMessageCollection = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Demo.Common.ServiceDefinition.ChatMessageCollection.Parser.ParseFrom);
    static readonly Marshaller<global::Demo.Common.ServiceDefinition.ChatMessage> __Marshaller_ChatMessage = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Demo.Common.ServiceDefinition.ChatMessage.Parser.ParseFrom);

    static readonly Method<global::Demo.Common.ServiceDefinition.AccountRequest, global::Demo.Common.ServiceDefinition.Account> __Method_GetAccount = new Method<global::Demo.Common.ServiceDefinition.AccountRequest, global::Demo.Common.ServiceDefinition.Account>(
        MethodType.Unary,
        __ServiceName,
        "GetAccount",
        __Marshaller_AccountRequest,
        __Marshaller_Account);

    static readonly Method<global::Demo.Common.ServiceDefinition.ChatMessageRequest, global::Demo.Common.ServiceDefinition.ChatMessageCollection> __Method_GetChatHistory = new Method<global::Demo.Common.ServiceDefinition.ChatMessageRequest, global::Demo.Common.ServiceDefinition.ChatMessageCollection>(
        MethodType.ClientStreaming,
        __ServiceName,
        "GetChatHistory",
        __Marshaller_ChatMessageRequest,
        __Marshaller_ChatMessageCollection);

    static readonly Method<global::Demo.Common.ServiceDefinition.ChatMessageRequest, global::Demo.Common.ServiceDefinition.ChatMessage> __Method_ListenChat = new Method<global::Demo.Common.ServiceDefinition.ChatMessageRequest, global::Demo.Common.ServiceDefinition.ChatMessage>(
        MethodType.ServerStreaming,
        __ServiceName,
        "ListenChat",
        __Marshaller_ChatMessageRequest,
        __Marshaller_ChatMessage);

    static readonly Method<global::Demo.Common.ServiceDefinition.ChatMessage, global::Demo.Common.ServiceDefinition.ChatMessage> __Method_Chat = new Method<global::Demo.Common.ServiceDefinition.ChatMessage, global::Demo.Common.ServiceDefinition.ChatMessage>(
        MethodType.DuplexStreaming,
        __ServiceName,
        "Chat",
        __Marshaller_ChatMessage,
        __Marshaller_ChatMessage);

    // service descriptor
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Demo.Common.ServiceDefinition.GameAdminServiceReflection.Descriptor.Services[0]; }
    }

    // client interface
    public interface IGameAdminServiceClient
    {
      global::Demo.Common.ServiceDefinition.Account GetAccount(global::Demo.Common.ServiceDefinition.AccountRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      global::Demo.Common.ServiceDefinition.Account GetAccount(global::Demo.Common.ServiceDefinition.AccountRequest request, CallOptions options);
      AsyncUnaryCall<global::Demo.Common.ServiceDefinition.Account> GetAccountAsync(global::Demo.Common.ServiceDefinition.AccountRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncUnaryCall<global::Demo.Common.ServiceDefinition.Account> GetAccountAsync(global::Demo.Common.ServiceDefinition.AccountRequest request, CallOptions options);
      AsyncClientStreamingCall<global::Demo.Common.ServiceDefinition.ChatMessageRequest, global::Demo.Common.ServiceDefinition.ChatMessageCollection> GetChatHistory(Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncClientStreamingCall<global::Demo.Common.ServiceDefinition.ChatMessageRequest, global::Demo.Common.ServiceDefinition.ChatMessageCollection> GetChatHistory(CallOptions options);
      AsyncServerStreamingCall<global::Demo.Common.ServiceDefinition.ChatMessage> ListenChat(global::Demo.Common.ServiceDefinition.ChatMessageRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncServerStreamingCall<global::Demo.Common.ServiceDefinition.ChatMessage> ListenChat(global::Demo.Common.ServiceDefinition.ChatMessageRequest request, CallOptions options);
      AsyncDuplexStreamingCall<global::Demo.Common.ServiceDefinition.ChatMessage, global::Demo.Common.ServiceDefinition.ChatMessage> Chat(Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncDuplexStreamingCall<global::Demo.Common.ServiceDefinition.ChatMessage, global::Demo.Common.ServiceDefinition.ChatMessage> Chat(CallOptions options);
    }

    // server-side interface
    public interface IGameAdminService
    {
      Task<global::Demo.Common.ServiceDefinition.Account> GetAccount(global::Demo.Common.ServiceDefinition.AccountRequest request, ServerCallContext context);
      Task<global::Demo.Common.ServiceDefinition.ChatMessageCollection> GetChatHistory(IAsyncStreamReader<global::Demo.Common.ServiceDefinition.ChatMessageRequest> requestStream, ServerCallContext context);
      Task ListenChat(global::Demo.Common.ServiceDefinition.ChatMessageRequest request, IServerStreamWriter<global::Demo.Common.ServiceDefinition.ChatMessage> responseStream, ServerCallContext context);
      Task Chat(IAsyncStreamReader<global::Demo.Common.ServiceDefinition.ChatMessage> requestStream, IServerStreamWriter<global::Demo.Common.ServiceDefinition.ChatMessage> responseStream, ServerCallContext context);
    }

    // client stub
    public class GameAdminServiceClient : ClientBase, IGameAdminServiceClient
    {
      public GameAdminServiceClient(Channel channel) : base(channel)
      {
      }
      public global::Demo.Common.ServiceDefinition.Account GetAccount(global::Demo.Common.ServiceDefinition.AccountRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_GetAccount, new CallOptions(headers, deadline, cancellationToken));
        return Calls.BlockingUnaryCall(call, request);
      }
      public global::Demo.Common.ServiceDefinition.Account GetAccount(global::Demo.Common.ServiceDefinition.AccountRequest request, CallOptions options)
      {
        var call = CreateCall(__Method_GetAccount, options);
        return Calls.BlockingUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::Demo.Common.ServiceDefinition.Account> GetAccountAsync(global::Demo.Common.ServiceDefinition.AccountRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_GetAccount, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::Demo.Common.ServiceDefinition.Account> GetAccountAsync(global::Demo.Common.ServiceDefinition.AccountRequest request, CallOptions options)
      {
        var call = CreateCall(__Method_GetAccount, options);
        return Calls.AsyncUnaryCall(call, request);
      }
      public AsyncClientStreamingCall<global::Demo.Common.ServiceDefinition.ChatMessageRequest, global::Demo.Common.ServiceDefinition.ChatMessageCollection> GetChatHistory(Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_GetChatHistory, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncClientStreamingCall(call);
      }
      public AsyncClientStreamingCall<global::Demo.Common.ServiceDefinition.ChatMessageRequest, global::Demo.Common.ServiceDefinition.ChatMessageCollection> GetChatHistory(CallOptions options)
      {
        var call = CreateCall(__Method_GetChatHistory, options);
        return Calls.AsyncClientStreamingCall(call);
      }
      public AsyncServerStreamingCall<global::Demo.Common.ServiceDefinition.ChatMessage> ListenChat(global::Demo.Common.ServiceDefinition.ChatMessageRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_ListenChat, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncServerStreamingCall(call, request);
      }
      public AsyncServerStreamingCall<global::Demo.Common.ServiceDefinition.ChatMessage> ListenChat(global::Demo.Common.ServiceDefinition.ChatMessageRequest request, CallOptions options)
      {
        var call = CreateCall(__Method_ListenChat, options);
        return Calls.AsyncServerStreamingCall(call, request);
      }
      public AsyncDuplexStreamingCall<global::Demo.Common.ServiceDefinition.ChatMessage, global::Demo.Common.ServiceDefinition.ChatMessage> Chat(Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_Chat, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncDuplexStreamingCall(call);
      }
      public AsyncDuplexStreamingCall<global::Demo.Common.ServiceDefinition.ChatMessage, global::Demo.Common.ServiceDefinition.ChatMessage> Chat(CallOptions options)
      {
        var call = CreateCall(__Method_Chat, options);
        return Calls.AsyncDuplexStreamingCall(call);
      }
    }

    // creates service definition that can be registered with a server
    public static ServerServiceDefinition BindService(IGameAdminService serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder(__ServiceName)
          .AddMethod(__Method_GetAccount, serviceImpl.GetAccount)
          .AddMethod(__Method_GetChatHistory, serviceImpl.GetChatHistory)
          .AddMethod(__Method_ListenChat, serviceImpl.ListenChat)
          .AddMethod(__Method_Chat, serviceImpl.Chat).Build();
    }

    // creates a new client
    public static GameAdminServiceClient NewClient(Channel channel)
    {
      return new GameAdminServiceClient(channel);
    }

  }
}
#endregion

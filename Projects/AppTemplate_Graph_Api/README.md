TEST REQUEST MODEL


POST /api/ApplicationTemplate/create-template HTTP/1.1
Host: localhost:5022
Content-Type: application/json
Content-Length: 152
Connection: close

{
  "DisplayName": "My Test App",
  "IdentifierUris": "api://my-test-app",
  "RedirectUri": "https://localhost:5001/callback"
}

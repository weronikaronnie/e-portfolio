const WebSocket = require('ws');

const wss = new WebSocket.Server({ port: 8080 });

const clients = [];

wss.on('connection', (ws) => {
  clients.push(ws);

  ws.on('message', (message) => {
    clients.forEach((client) => {
      if (client !== ws && client.readyState === WebSocket.OPEN) {
        client.send(message);
      }
    });
  });

  ws.on('close', () => {
    clients.splice(clients.indexOf(ws), 1);
  });
});

console.log('Chat server is running on port 8080...');

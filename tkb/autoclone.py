from urllib.parse import urlencode
from urllib.request import Request, urlopen
import threading,random,time
url = 'https://tkbremake3webversion.herokuapp.com/signup' # Set destination URL here
def get_random(size):
	out = ""
	for i in range(size):
		a = random.randint(97,122)
		out += chr(a)
	return out
def run():
	while True:
		try:
			x = time.time()
			a = get_random(6)
			b = get_random(6)
			c = get_random(6)
			post_fields = {'_user': a,'_pass':b,'_email':'%s@asd.com'%c}     # Set POST fields here
			
			request = Request(url, urlencode(post_fields).encode())
			json = urlopen(request).read().decode()
			
			#print("Trying user [%s] with password [%s] and email is [%s] in times %ss"%(a,b,c,y-x))
			print(post_fields, "times in ",end="")
			
			y = time.time()
			print("%ss with status"%(y-x))
			if json == 'true':
				print("[Successful]")
			else:
				print("[Failed]")
		except:
			print("SERVER ERRORS")
			break
t = threading.Thread(target=run)
t.start()
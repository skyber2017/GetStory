import requests

ch = {"email":"duy","pass":"a"}
a = requests.post("facebook.com/login.php",cookies=ch)
print(a.text)
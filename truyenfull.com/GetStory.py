import requests
from bs4 import BeautifulSoup as bs
import sys,os
def getS(url,ten,i):
    
    page = requests.get(url+"/chuong-%s/"%i)
    soup = bs(page.text,"html.parser")
    a = soup.findAll(class_="chapter-c")
    if a == []: return False
    s = []
    for i in a:
        s.append(i.getText())
    return s
def getTen(url):
    page = requests.get(url)
    soup = bs(page.text,"html.parser")
    a = soup.findAll(class_="truyen-title")
    return a[0].getText()
url = input("Nhap url:")
sl = int(input("Nhap so chuong:"))
ten = getTen(url+"/chuong-%s"%sl)
failed = []
dem = 0
for i in range(1,sl+1):
    print("Dang tai chuong %s"%i)
    x = getS(url,ten,i)
    if x == False:
        #dem += 1
        print("Chuong %s nay bi loi,Vui long kiem tra lai URL!!!"%i)
        failed.append(i)
        
    else:
        filename = "%s/chuong-%s.txt"%(ten,i)
        if not os.path.exists(os.path.dirname(filename)):
            try:
                print(filename)
                os.makedirs(os.path.dirname(filename))
            except:
                print("Tao thu muc bi loi...")
        with open(filename,"w",encoding='utf-8') as f:
            for k in x:
                f.write(k)
    
        
if len(failed) > 0:
    print("Co %s chuong bi loi!!"%(len(failed)))
    print("Chuong bi loi la:",end="")
    for i in failed:
        print(i,end=" ")
    
else:
    print("Tai hoan tat")

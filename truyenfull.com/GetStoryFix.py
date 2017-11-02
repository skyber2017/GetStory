
import requests
from bs4 import BeautifulSoup as bs
import sys,os

def getS(url,ten,i,j):
    dem = 0
    page = requests.get(url+"/chuong-%s-%s/"%(i,j))
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
sl = [int(i) for i in input("Nhap nhung chuong bi loi:").split()]

ten = getTen(url+"/chuong-2")
    
failed = []
dem = 0
for i in sl:
    for j in range(1,10):
        print("Dang tai chuong %s-%s"%(i,j))
        x = getS(url,ten,i,j)
        if x == False:
            print("CHUONG %s-%s KHONG TON TAI!!"%(i,j))
            break
            
        else:
            filename = "%s/chuong-%s-%s.txt"%(ten,i,j)
            if not os.path.exists(os.path.dirname(filename)):
                try:
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

import requests
import os
from bs4 import BeautifulSoup as bs

class getStory():
    
    def __init__(self,url=""):
        
        if url == "":
            print("Ban chua nhap URL!!")
            url = input("Vui long nhap URL:")
        else:
            self.url = url
        self.page = requests.get(self.url)
        self.soup = bs(self.page.text,"html.parser")
        asc =[":","?","<",">","\n"]
        x = self.soup.findAll(class_="story-intro-title")[0].getText()
        for i in asc:
            x = x.replace(i,"")
        self.ten = x
        href = self.soup.findAll(class_="tab-text")
        for i in href:
            self.href = ["http://thichtruyen.vn"+j['href'] for j in i.findAll('a')]
        #print(self.href)
        #chapter = self.soup.findAll(class_="story-intro-chapper")
        self.chap = len(self.href)
        #print(self.href)
    def createDir(self,i,x):
        filename = "%s/chuong-%s.txt"%(self.ten,i)
        if not os.path.exists(os.path.dirname(filename)):
            try:
                os.makedirs(os.path.dirname(filename))
            except:
                print("Tao thu muc bi loi")
        with open(filename,'w',encoding="utf-8") as f:
            f.write(x)
            

    def get(self):
        failed =[]
        for j in self.href:
            try:
                Chap = int(''.join([i for i in j if i.isdigit()]))
            except:
                Chap = "ngoai-truyen"
                print("Khong the lay so chuong!!")
            #print(Chap)
            try:
                page = requests.get(j)
                sp = bs(page.text,"html.parser")
                a = sp.findAll(class_="story-detail-content")
                #print("a")
                #nameChap = [i.find('b').getText() for i in a]
                
                for i in a:
                    x = i.getText(separator="\n").replace("(adsbygoogle = window.adsbygoogle || []).push({});","")
                    x = x.replace("\n\n","")
                print("Dang tai chuong %s"%Chap)
                self.createDir(Chap,x)
            except:
                print("Chuong %s bi loi!"%Chap)
                failed.append(Chap)
        if len(failed) > 0:
            print("Co tat ca %s chuong bi loi!"%len(failed))
            print("Chuong bi loi la:",[i for i in failed])
        else:
            print("Tai hoan tat")
            
    def run(self):
        self.get()

print("Xin chao day la he thong tai truyen tu thichtruyen.vn")
url = ""
while url == "":
    url = input("Nhap URL:")
try:
    a = getStory(url)
    a.run()
except:
    print("URL sai! Vui long chay lai chuong trinh!")

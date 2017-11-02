import json,os
def get(ten):
    a = []
    for i in range(1,len(os.listdir("%s/"%ten))+1):
        with open("%s/chuong-%s.txt"%(ten,i),'r',encoding="utf8") as f:
            a.append(f.read())
    with open("json.txt","w",encoding="utf8") as f:
        f.write(json.dumps(a))
ten = input("Nhap ten truyen:")
get(ten)


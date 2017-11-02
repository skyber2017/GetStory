import json
with open("json.txt","r",encoding='utf-8') as f:
    print(json.loads(f.read()))

from flask import Flask,render_template,request
import requests
app = Flask(__name__)

@app.route("/login",methods=['POST'])
def login():	
	_email = request.form['email']
	_pass = request.form['pass']
	if _email and _pass:
		return "hello %s"%_email
	
    #return render_template("hello.html")
@app.route("/")
def index():
	return render_template("hello.html")
@app.route("/hello/<string:user>")
def hello(user):
    return "Hello %s"%user
if __name__ == "__main__":
    app.run(debug=True)

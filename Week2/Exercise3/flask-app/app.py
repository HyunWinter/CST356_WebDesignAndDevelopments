from flask import Flask, render_template
import random

app = Flask(__name__)

# list of cat images
images = [
   "https://media1.giphy.com/media/3o6Zt481isNVuQI1l6/giphy.gif",
    "https://media0.giphy.com/media/l4KibK3JwaVo0CjDO/giphy.gif",
    "https://media0.giphy.com/media/VbnUQpnihPSIgIXuZv/giphy.gif",
    "https://media1.giphy.com/media/vFKqnCdLPNOKc/giphy.gif",
    "https://media0.giphy.com/media/BzyTuYCmvSORqs1ABM/giphy.gif",
    "https://media4.giphy.com/media/CqVNwrLt9KEDK/giphy.gif",
    "https://media0.giphy.com/media/yFQ0ywscgobJK/giphy.gif",
    "https://media3.giphy.com/media/CjmvTCZf2U3p09Cn0h/giphy.gif",
    "https://media4.giphy.com/media/3oriO0OEd9QIDdllqo/giphy.gif",
    "https://media4.giphy.com/media/33OrjzUFwkwEg/giphy.gif",
    "https://media4.giphy.com/media/13CoXDiaCcCoyk/giphy.gif",
    "https://media2.giphy.com/media/12PA1eI8FBqEBa/giphy.gif"
    ]

@app.route('/')
def index():
    url = random.choice(images)
    return render_template('index.html', url=url)

if __name__ == "__main__":
    app.run(host="0.0.0.0")
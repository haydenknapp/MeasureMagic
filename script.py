from bottle import route, request, run

def calcTotal(sleeveLength, seamAllowance, biggestFactor, shirtLength, bicepCircumference):
    if (sleeveLength + seamAllowance * 2 + shirtLength) <= 45:
        return biggestFactor * 2
    else:
        return biggestFactor * 2 + bicepCircumference
    return biggestFactor * 2 + bicepCircumference

# redirect the user to the form page
@route('/')
def indexRedirect():
    return '<meta http-equiv="refresh" content="0; url=/form/init">'

# the page where the form is. Takes the status from the last fill in if
# it was not successful.
@route('/form/<status>')
def formPage(status):
    ret = """<html>
    <head>
    <title>Measure Magic</title>
    </head>
    <h1>Enter your measurements!</h1>
    <form action="/fabrics" method="post">
    Neck Circumference <input type="text" name="neckCircumference"><br>
    Shoulder Width <input type="text" name="shoulderWidth"><br>
    Sleeve Length <input type="text" name="sleeveLength"><br>
    Waist Around <input type="text" name="waistAround"><br>
    Shirt Length <input type="text" name="shirtLength"><br>
    Bicep Circumference <input type="text" name="bicepCircumference"><br>
    Chest Circumference <input type="text" name="chestCircumference"><br>
    Seam Allowance <input type="text" name="seamAllowance"><br>
    <input type="submit" value="Submit">
    </html>"""
    if status == 'missingInput':
        ret += "<br>Please fill in missing data and resubmit<br>"
    return ret

# source for first paragraph of the elaboration https://wiki.installgentoo.com/index.php/Interjection

@route('/fabrics', method = 'POST')
def fabricsPage():
    neckCircumference = int(request.forms.get('neckCircumference'))
    shoulderWidth = int(request.forms.get('shoulderWidth'))
    sleeveLength = int(request.forms.get('sleeveLength'))
    waistAround = int(request.forms.get('waistAround'))
    shirtLength = int(request.forms.get('shirtLength'))
    bicepCircumference = int(request.forms.get('bicepCircumference'))
    chestCircumference = int(request.forms.get('chestCircumference'))
    seamAllowance = int(request.forms.get('seamAllowance'))
    print(seamAllowance)

    biggestFactor = max(shoulderWidth, chestCircumference, waistAround)
    total = calcTotal(sleeveLength, seamAllowance, biggestFactor, shirtLength, bicepCircumference)
    ret = '<html><head><title>Measure Magic</title></head><h1>Select your fabrics!</h1><form action="/results/'
    ret += str(total)
    ret += """" method="post">
    <input type="radio" name="fabricType" value="silk" checked>Silk<br>
    <input type="radio" name="fabricType" value="cotton" checked>Cotton<br>
    <input type="radio" name="fabricType" value="denim" checked>Denim<br>
    <input type="radio" name="fabricType" value="flannel" checked>Fleece<br>
    <input type="radio" name="fabricType" value="linen" checked>Linen<br>
    <input type="radio" name="fabricType" value="polyester" checked>Polyester<br>
    <br>
    Color
    <select id="pickColor" name="color">
    <option name="color" value="black">Black</option>
    <option name="color" value="white">White</option>
    <option name="color" value="blue">Blue</option>
    <option name="color" value="green">Green</option>
    <option name="color" value="red">Red</option>
    <option name="color" value="smaragdine">Smaragdine</option>
    </select>
    <input type="submit" value="Submit">
    </form>
    </html>"""
    return ret

@route('/results/<length>', method='POST')
def resultsPage(length):
    fabricType = request.forms.get('fabricType')
    color = request.forms.get('color')
    ret = """<html><head><title>Your fabric</title></head>"""
    ret += """<h1>The length you need is """
    ret += length
    ret += """ inches of fabric.</h1>"""
    ret += """<p>Find the materials you need, at the lowest prices!</p>"""
    ret += '<p><a href="http://www.joann.com/search?q=' + fabricType + '+' + color
    ret += '">JOANN Fabric</a></p>'
    return ret

if __name__ == '__main__':
    run(debug=True)

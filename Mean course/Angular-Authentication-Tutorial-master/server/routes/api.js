const express = require('express');
const router = express.Router();
const mongoose = require('mongoose');
const User = require('../models/user');
const  Course  = require('../models/course');
const EnrolledCourse  = require('../models/EnrolledCourse');
const jwt = require('jsonwebtoken')
let userId=""
mongoose.Promise = global.Promise;
const db = "mongodb://localhost:27017/pritam_db";

mongoose.connect(db, function(err){
    if(err){
        console.error('Error! ' + err)
    } else {
      console.log('Connected to mongodb')      
    }
});

function verifyToken(req, res, next) {
  if(!req.headers.authorization) {
    return res.status(401).send('Unauthorized request')
  }
  let token = req.headers.authorization.split(' ')[1]
  if(token === 'null') {
    return res.status(401).send('Unauthorized request')    
  }
  let payload = jwt.verify(token, 'secretKey')
  if(!payload) {
    return res.status(401).send('Unauthorized request')    
  }
  req.userId = payload.subject
  next()
}

router.get('/events', (req, res) => {
  Course.find((err, docs) => {
      if (!err) { res.send(docs); }
      else { console.log('Error in Retriving Employees :' + JSON.stringify(err, undefined, 2)); }
  });
});

router.post('/events', (req, res) => {
  let eventData = req.body
  //userId =  req.body.studentId
  //console.log("*********"+userId)
  let events = new Course(eventData)
  events.save((err, registeredEvents) => {
    if (err) {
      console.log(err)      
    } else {
      res.status(200).send(registeredEvents)
    }
  })
});



router.get('/special',  (req, res) => {

  console.log("******from special get method Api**" + userId);
  EnrolledCourse.find({ $or: [{ studentId: userId }] },(err, docs) => {
      if (!err) { res.send(docs); }
      else { console.log('Error in Retriving Courses :' + JSON.stringify(err, undefined, 2)); }
  });
});

router.post('/special', (req, res) => {
  let SpecialEventData = req.body
  userId = req.body.studentId
  console.log("*******from Post Method Api*****"+ userId);
  let specialevents = new EnrolledCourse(SpecialEventData)
  specialevents.save((err, enrolledEvents) => {
    if (err) {
      console.log(err)      
    } else {
      res.status(200).send(enrolledEvents)
    }
  })
});


router.post('/register', (req, res) => {
  let userData = req.body
  userId = req.body.email
  let user = new User(userData)
  user.save((err, registeredUser) => {
    if (err) {
      console.log(err)      
    } else {
      let payload = {subject: registeredUser._id}
     
      let token = jwt.sign(payload, 'secretKey')
      res.status(200).send({token})
    }
  })
})

router.post('/login', (req, res) => {
  let userData = req.body
  userId = req.body.email
  User.findOne({email: userData.email}, (err, user) => {
    if (err) {
      console.log(err)    
    } else {
      if (!user) {
        res.status(401).send('Invalid Email')
      } else 
      if ( user.password !== userData.password) {
        res.status(401).send('Invalid Password')
      } else {
        let payload = {subject: user._id}
        let token = jwt.sign(payload, 'secretKey')
        let sample = {email : user.email, key:token}
        res.status(200).send({sample})
      }
    }
  })
})

module.exports = router;
const express = require('express')
const router = express.Router()
const bodyParser = require('body-parser')

var controllers_album = require('../controllers/album_c');

router.use(bodyParser.urlencoded({extended : true}))
      

// get all albums
router.get('/',controllers_album.find_all)

// get a selected album
router.get('/:id',controllers_album.find_one)

//post an album
router.post('/', controllers_album.add)

//delete an album
router.put('/:id', controllers_album.delete)

//Edit an album
router.post('/:id', controllers_album.update)

module.exports = router
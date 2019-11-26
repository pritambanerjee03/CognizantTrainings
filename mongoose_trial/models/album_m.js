const mongoose =  require('mongoose')

const album = mongoose.model("album",{

    album_id : String,
    album_name : String,
    artist_name : String
})

module.exports = album
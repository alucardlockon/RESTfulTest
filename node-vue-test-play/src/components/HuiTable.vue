<template>
  <div class="hui-list">
    <ol>
      <li v-for="data in datas">
      </li>
    </ol>
    <table class="table">
      <thead>
        <tr>
          <!-- <th v-for="data in datas">{{data.name}}</th> -->
          <th>name</th>
          <th>maker</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="data in datas">
          <td>{{data.name}}</td>
          <td>{{data.maker}}</td>
        </tr>
      </tbody>
    </table>
  </div>
</template>
<script>
export default {
  name: 'hui-table',
  props: ['data'],
  data () {
    return {
      datas: [
        { name: 'ps4', maker: 'sony' },
        { name: 'ps3', maker: 'sony' },
        { name: 'wii', maker: 'nintendo' },
        { name: 'wiiu', maker: 'nintendo' },
        { name: 'xbox360', maker: 'microsoft' },
        { name: 'xboxOne', maker: 'microsoft' }
      ]
    }
  },
  created: function (){
      this.$http.Get(https://raw.githubusercontent.com/alucardlockon/RESTfulTest/master/node-vue-test-play/static/json/tabledata.json);
  }
  
}
</script>
<style>
.hui-list{
  //width: 100%;
}
</style>
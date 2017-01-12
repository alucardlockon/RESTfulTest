<template>
  <div class="hui-list">
    <!-- <ol>
      <li v-for="data in datas">
      </li>
    </ol> -->
    <table class="table table-striped">
      <thead>
        <tr>
          <th v-for="head in theads"  style="text-align:center">{{head}}</th>
          <!-- <th style="text-align:center">name</th>
          <th style="text-align:center">maker</th> -->
        </tr>
      </thead>
      <tbody>
        <tr v-for="data in datas">
          <td v-for="head in theads">{{data[head]}}</td>
        </tr>
        <!-- <tr v-for="data in datas">
          <td>{{data.name}}</td>
          <td>{{data.maker}}</td>
        </tr> -->
      </tbody>
    </table>
  </div>
</template>
<script>
export default {
  name: 'hui-table',
  props: ['dataurl'],
  data () {
    return {
      datas: [
        { name: 'ps4', maker: 'sony', gg: 'ccc' },
        { name: 'ps3', maker: 'sony' },
        { name: 'wii', maker: 'nintendo' },
        { name: 'wiiu', maker: 'nintendo' },
        { name: 'xbox360', maker: 'microsoft' },
        { name: 'xboxOne', maker: 'microsoft' }
      ]
    }
  },
  created: function () {
    let url = 'https://raw.githubusercontent.com/alucardlockon/RESTfulTest/master/node-vue-test-play/static/json/tabledata.json'
    this.$http.get(url, {}).then((response) => {
      console.log(response.data)
      this.datas = JSON.parse(response.data).datas
    })
    // this.$http.get('https://raw.githubusercontent.com/alucardlockon/RESTfulTest/master/node-vue-test-play/static/json/tabledata.json')
  },
  computed: {
    // 仅读取，值只须为函数
    theads: function () {
      var arr = []
      for (let index in this.datas) {
        for (let da in this.datas[index]) {
          arr.push(da)
        }
        if (arr.length > 0) break
      }
      return arr
    }
  }
}
</script>
<style>
.hui-list{
  width: 100%;
}
</style>
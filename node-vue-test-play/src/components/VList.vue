<template>
  <div class="v-list">
    <ul>
      <li>{{message}}</li>
    </ul>
  </div>
</template>
<script>
export default {
  name: 'v-list',
  props: ['message'],
  data () {
    return {
      item: '111'
    }
  }
}
</script>
<style>
.v-list{
  width: 100%;
}
</style>
<template>
  <div>
    <div class="text-center">
      <h1>{{this.currentVault.name}}</h1>
    </div>
    <div class="container-fluid">
      <h1 class="text-left">Keeps</h1>
      <div class="row" id="keepRow">
        <keep v-for="keep in keepData" :key="keep.vaultkeepId" :keepProp="keep" />
      </div>
    </div>
  </div>
</template>

<script>
import keep from "../components/keep";

export default {
  name: "currentVault",

  mounted() {
    return this.$store.state.currentVault;
  },

  computed: {
    currentVault() {
      return this.$store.state.currentVault;
    },
    keepData() {
      return this.$store.state.currentVault.keeps;
    }
  },

  components: {
    keep
  },

  methods: {}
};
</script>

<style>
</style>
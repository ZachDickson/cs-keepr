<template>
  <div class="col-3">
    <div id="keepCard" class="card mb-3 shadow p-3 mb-5 bg-black rounded">
      <router-link to="/currentVault">
        <h3 @click="setCurrentVault" class="card-header">{{vaultProp.name}}</h3>
      </router-link>
      <div class="card-body">
        <p class="card-text">{{vaultProp.description}}</p>
      </div>
      <div id="delete" @click="deleteVault" class="text-danger">Delete Vault</div>
    </div>
  </div>
</template>

<script>
export default {
  name: "vault",

  props: ["vaultProp"],

  mounted() {},

  computed: {},

  methods: {
    deleteVault() {
      this.$store.dispatch("deleteVault", this.vaultProp.id);
    },

    setCurrentVault() {
      this.$store.dispatch("getKeepsByVaultId", this.vaultProp);
    }
  }
};
</script>

<style>
</style>
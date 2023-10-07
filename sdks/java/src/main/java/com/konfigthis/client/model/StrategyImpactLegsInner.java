/*
 * SnapTrade
 * Connect brokerage accounts to your app for live positions and trading
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: api@snaptrade.com
 *
 * NOTE: This class is auto generated by Konfig (https://konfigthis.com).
 * Do not edit the class manually.
 */


package com.konfigthis.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonArray;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;
import org.apache.commons.lang3.StringUtils;

import java.lang.reflect.Type;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Map.Entry;
import java.util.Set;

import com.konfigthis.client.JSON;

/**
 * StrategyImpactLegsInner
 */@javax.annotation.Generated(value = "Generated by https://konfigthis.com")
public class StrategyImpactLegsInner {
  public static final String SERIALIZED_NAME_LEG_ID = "legId";
  @SerializedName(SERIALIZED_NAME_LEG_ID)
  private Integer legId;

  public static final String SERIALIZED_NAME_SYMBOL = "symbol";
  @SerializedName(SERIALIZED_NAME_SYMBOL)
  private String symbol;

  public static final String SERIALIZED_NAME_SYMBOL_ID = "symbolId";
  @SerializedName(SERIALIZED_NAME_SYMBOL_ID)
  private Integer symbolId;

  public static final String SERIALIZED_NAME_LEG_RATIO_QUANTITY = "legRatioQuantity";
  @SerializedName(SERIALIZED_NAME_LEG_RATIO_QUANTITY)
  private Integer legRatioQuantity;

  public static final String SERIALIZED_NAME_SIDE = "side";
  @SerializedName(SERIALIZED_NAME_SIDE)
  private String side;

  public static final String SERIALIZED_NAME_AVG_EXEC_PRICE = "avgExecPrice";
  @SerializedName(SERIALIZED_NAME_AVG_EXEC_PRICE)
  private String avgExecPrice;

  public static final String SERIALIZED_NAME_LAST_EXEC_PRICE = "lastExecPrice";
  @SerializedName(SERIALIZED_NAME_LAST_EXEC_PRICE)
  private String lastExecPrice;

  public StrategyImpactLegsInner() {
  }

  public StrategyImpactLegsInner legId(Integer legId) {
    
    
    
    
    this.legId = legId;
    return this;
  }

   /**
   * Get legId
   * @return legId
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "0", value = "")

  public Integer getLegId() {
    return legId;
  }


  public void setLegId(Integer legId) {
    
    
    
    this.legId = legId;
  }


  public StrategyImpactLegsInner symbol(String symbol) {
    
    
    
    
    this.symbol = symbol;
    return this;
  }

   /**
   * Get symbol
   * @return symbol
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "AC21Oct22C30.00.MX", value = "")

  public String getSymbol() {
    return symbol;
  }


  public void setSymbol(String symbol) {
    
    
    
    this.symbol = symbol;
  }


  public StrategyImpactLegsInner symbolId(Integer symbolId) {
    
    
    
    
    this.symbolId = symbolId;
    return this;
  }

   /**
   * Get symbolId
   * @return symbolId
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "41790511", value = "")

  public Integer getSymbolId() {
    return symbolId;
  }


  public void setSymbolId(Integer symbolId) {
    
    
    
    this.symbolId = symbolId;
  }


  public StrategyImpactLegsInner legRatioQuantity(Integer legRatioQuantity) {
    
    
    
    
    this.legRatioQuantity = legRatioQuantity;
    return this;
  }

   /**
   * Get legRatioQuantity
   * @return legRatioQuantity
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "1", value = "")

  public Integer getLegRatioQuantity() {
    return legRatioQuantity;
  }


  public void setLegRatioQuantity(Integer legRatioQuantity) {
    
    
    
    this.legRatioQuantity = legRatioQuantity;
  }


  public StrategyImpactLegsInner side(String side) {
    
    
    
    
    this.side = side;
    return this;
  }

   /**
   * Get side
   * @return side
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "BTO", value = "")

  public String getSide() {
    return side;
  }


  public void setSide(String side) {
    
    
    
    this.side = side;
  }


  public StrategyImpactLegsInner avgExecPrice(String avgExecPrice) {
    
    
    
    
    this.avgExecPrice = avgExecPrice;
    return this;
  }

   /**
   * Get avgExecPrice
   * @return avgExecPrice
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getAvgExecPrice() {
    return avgExecPrice;
  }


  public void setAvgExecPrice(String avgExecPrice) {
    
    
    
    this.avgExecPrice = avgExecPrice;
  }


  public StrategyImpactLegsInner lastExecPrice(String lastExecPrice) {
    
    
    
    
    this.lastExecPrice = lastExecPrice;
    return this;
  }

   /**
   * Get lastExecPrice
   * @return lastExecPrice
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getLastExecPrice() {
    return lastExecPrice;
  }


  public void setLastExecPrice(String lastExecPrice) {
    
    
    
    this.lastExecPrice = lastExecPrice;
  }

  /**
   * A container for additional, undeclared properties.
   * This is a holder for any undeclared properties as specified with
   * the 'additionalProperties' keyword in the OAS document.
   */
  private Map<String, Object> additionalProperties;

  /**
   * Set the additional (undeclared) property with the specified name and value.
   * If the property does not already exist, create it otherwise replace it.
   *
   * @param key name of the property
   * @param value value of the property
   * @return the StrategyImpactLegsInner instance itself
   */
  public StrategyImpactLegsInner putAdditionalProperty(String key, Object value) {
    if (this.additionalProperties == null) {
        this.additionalProperties = new HashMap<String, Object>();
    }
    this.additionalProperties.put(key, value);
    return this;
  }

  /**
   * Return the additional (undeclared) property.
   *
   * @return a map of objects
   */
  public Map<String, Object> getAdditionalProperties() {
    return additionalProperties;
  }

  /**
   * Return the additional (undeclared) property with the specified name.
   *
   * @param key name of the property
   * @return an object
   */
  public Object getAdditionalProperty(String key) {
    if (this.additionalProperties == null) {
        return null;
    }
    return this.additionalProperties.get(key);
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    StrategyImpactLegsInner strategyImpactLegsInner = (StrategyImpactLegsInner) o;
    return Objects.equals(this.legId, strategyImpactLegsInner.legId) &&
        Objects.equals(this.symbol, strategyImpactLegsInner.symbol) &&
        Objects.equals(this.symbolId, strategyImpactLegsInner.symbolId) &&
        Objects.equals(this.legRatioQuantity, strategyImpactLegsInner.legRatioQuantity) &&
        Objects.equals(this.side, strategyImpactLegsInner.side) &&
        Objects.equals(this.avgExecPrice, strategyImpactLegsInner.avgExecPrice) &&
        Objects.equals(this.lastExecPrice, strategyImpactLegsInner.lastExecPrice)&&
        Objects.equals(this.additionalProperties, strategyImpactLegsInner.additionalProperties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(legId, symbol, symbolId, legRatioQuantity, side, avgExecPrice, lastExecPrice, additionalProperties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class StrategyImpactLegsInner {\n");
    sb.append("    legId: ").append(toIndentedString(legId)).append("\n");
    sb.append("    symbol: ").append(toIndentedString(symbol)).append("\n");
    sb.append("    symbolId: ").append(toIndentedString(symbolId)).append("\n");
    sb.append("    legRatioQuantity: ").append(toIndentedString(legRatioQuantity)).append("\n");
    sb.append("    side: ").append(toIndentedString(side)).append("\n");
    sb.append("    avgExecPrice: ").append(toIndentedString(avgExecPrice)).append("\n");
    sb.append("    lastExecPrice: ").append(toIndentedString(lastExecPrice)).append("\n");
    sb.append("    additionalProperties: ").append(toIndentedString(additionalProperties)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }


  public static HashSet<String> openapiFields;
  public static HashSet<String> openapiRequiredFields;

  static {
    // a set of all properties/fields (JSON key names)
    openapiFields = new HashSet<String>();
    openapiFields.add("legId");
    openapiFields.add("symbol");
    openapiFields.add("symbolId");
    openapiFields.add("legRatioQuantity");
    openapiFields.add("side");
    openapiFields.add("avgExecPrice");
    openapiFields.add("lastExecPrice");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
  }

 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to StrategyImpactLegsInner
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
      if (jsonObj == null) {
        if (!StrategyImpactLegsInner.openapiRequiredFields.isEmpty()) { // has required fields but JSON object is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in StrategyImpactLegsInner is not found in the empty JSON string", StrategyImpactLegsInner.openapiRequiredFields.toString()));
        }
      }
      if ((jsonObj.get("symbol") != null && !jsonObj.get("symbol").isJsonNull()) && !jsonObj.get("symbol").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `symbol` to be a primitive type in the JSON string but got `%s`", jsonObj.get("symbol").toString()));
      }
      if ((jsonObj.get("side") != null && !jsonObj.get("side").isJsonNull()) && !jsonObj.get("side").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `side` to be a primitive type in the JSON string but got `%s`", jsonObj.get("side").toString()));
      }
      if ((jsonObj.get("avgExecPrice") != null && !jsonObj.get("avgExecPrice").isJsonNull()) && !jsonObj.get("avgExecPrice").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `avgExecPrice` to be a primitive type in the JSON string but got `%s`", jsonObj.get("avgExecPrice").toString()));
      }
      if ((jsonObj.get("lastExecPrice") != null && !jsonObj.get("lastExecPrice").isJsonNull()) && !jsonObj.get("lastExecPrice").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `lastExecPrice` to be a primitive type in the JSON string but got `%s`", jsonObj.get("lastExecPrice").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!StrategyImpactLegsInner.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'StrategyImpactLegsInner' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<StrategyImpactLegsInner> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(StrategyImpactLegsInner.class));

       return (TypeAdapter<T>) new TypeAdapter<StrategyImpactLegsInner>() {
           @Override
           public void write(JsonWriter out, StrategyImpactLegsInner value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             obj.remove("additionalProperties");
             // serialize additonal properties
             if (value.getAdditionalProperties() != null) {
               for (Map.Entry<String, Object> entry : value.getAdditionalProperties().entrySet()) {
                 if (entry.getValue() instanceof String)
                   obj.addProperty(entry.getKey(), (String) entry.getValue());
                 else if (entry.getValue() instanceof Number)
                   obj.addProperty(entry.getKey(), (Number) entry.getValue());
                 else if (entry.getValue() instanceof Boolean)
                   obj.addProperty(entry.getKey(), (Boolean) entry.getValue());
                 else if (entry.getValue() instanceof Character)
                   obj.addProperty(entry.getKey(), (Character) entry.getValue());
                 else {
                   obj.add(entry.getKey(), gson.toJsonTree(entry.getValue()).getAsJsonObject());
                 }
               }
             }
             elementAdapter.write(out, obj);
           }

           @Override
           public StrategyImpactLegsInner read(JsonReader in) throws IOException {
             JsonObject jsonObj = elementAdapter.read(in).getAsJsonObject();
             validateJsonObject(jsonObj);
             // store additional fields in the deserialized instance
             StrategyImpactLegsInner instance = thisAdapter.fromJsonTree(jsonObj);
             for (Map.Entry<String, JsonElement> entry : jsonObj.entrySet()) {
               if (!openapiFields.contains(entry.getKey())) {
                 if (entry.getValue().isJsonPrimitive()) { // primitive type
                   if (entry.getValue().getAsJsonPrimitive().isString())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsString());
                   else if (entry.getValue().getAsJsonPrimitive().isNumber())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsNumber());
                   else if (entry.getValue().getAsJsonPrimitive().isBoolean())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsBoolean());
                   else
                     throw new IllegalArgumentException(String.format("The field `%s` has unknown primitive type. Value: %s", entry.getKey(), entry.getValue().toString()));
                 } else if (entry.getValue().isJsonArray()) {
                     instance.putAdditionalProperty(entry.getKey(), gson.fromJson(entry.getValue(), List.class));
                 } else { // JSON object
                     instance.putAdditionalProperty(entry.getKey(), gson.fromJson(entry.getValue(), HashMap.class));
                 }
               }
             }
             return instance;
           }

       }.nullSafe();
    }
  }

 /**
  * Create an instance of StrategyImpactLegsInner given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of StrategyImpactLegsInner
  * @throws IOException if the JSON string is invalid with respect to StrategyImpactLegsInner
  */
  public static StrategyImpactLegsInner fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, StrategyImpactLegsInner.class);
  }

 /**
  * Convert an instance of StrategyImpactLegsInner to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}


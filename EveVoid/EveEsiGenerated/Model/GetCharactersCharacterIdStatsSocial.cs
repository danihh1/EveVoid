using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// social object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdStatsSocial {
    /// <summary>
    /// add_contact_bad integer
    /// </summary>
    /// <value>add_contact_bad integer</value>
    [DataMember(Name="add_contact_bad", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add_contact_bad")]
    public long? AddContactBad { get; set; }

    /// <summary>
    /// add_contact_good integer
    /// </summary>
    /// <value>add_contact_good integer</value>
    [DataMember(Name="add_contact_good", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add_contact_good")]
    public long? AddContactGood { get; set; }

    /// <summary>
    /// add_contact_high integer
    /// </summary>
    /// <value>add_contact_high integer</value>
    [DataMember(Name="add_contact_high", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add_contact_high")]
    public long? AddContactHigh { get; set; }

    /// <summary>
    /// add_contact_horrible integer
    /// </summary>
    /// <value>add_contact_horrible integer</value>
    [DataMember(Name="add_contact_horrible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add_contact_horrible")]
    public long? AddContactHorrible { get; set; }

    /// <summary>
    /// add_contact_neutral integer
    /// </summary>
    /// <value>add_contact_neutral integer</value>
    [DataMember(Name="add_contact_neutral", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add_contact_neutral")]
    public long? AddContactNeutral { get; set; }

    /// <summary>
    /// add_note integer
    /// </summary>
    /// <value>add_note integer</value>
    [DataMember(Name="add_note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add_note")]
    public long? AddNote { get; set; }

    /// <summary>
    /// added_as_contact_bad integer
    /// </summary>
    /// <value>added_as_contact_bad integer</value>
    [DataMember(Name="added_as_contact_bad", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "added_as_contact_bad")]
    public long? AddedAsContactBad { get; set; }

    /// <summary>
    /// added_as_contact_good integer
    /// </summary>
    /// <value>added_as_contact_good integer</value>
    [DataMember(Name="added_as_contact_good", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "added_as_contact_good")]
    public long? AddedAsContactGood { get; set; }

    /// <summary>
    /// added_as_contact_high integer
    /// </summary>
    /// <value>added_as_contact_high integer</value>
    [DataMember(Name="added_as_contact_high", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "added_as_contact_high")]
    public long? AddedAsContactHigh { get; set; }

    /// <summary>
    /// added_as_contact_horrible integer
    /// </summary>
    /// <value>added_as_contact_horrible integer</value>
    [DataMember(Name="added_as_contact_horrible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "added_as_contact_horrible")]
    public long? AddedAsContactHorrible { get; set; }

    /// <summary>
    /// added_as_contact_neutral integer
    /// </summary>
    /// <value>added_as_contact_neutral integer</value>
    [DataMember(Name="added_as_contact_neutral", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "added_as_contact_neutral")]
    public long? AddedAsContactNeutral { get; set; }

    /// <summary>
    /// calendar_event_created integer
    /// </summary>
    /// <value>calendar_event_created integer</value>
    [DataMember(Name="calendar_event_created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "calendar_event_created")]
    public long? CalendarEventCreated { get; set; }

    /// <summary>
    /// chat_messages_alliance integer
    /// </summary>
    /// <value>chat_messages_alliance integer</value>
    [DataMember(Name="chat_messages_alliance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chat_messages_alliance")]
    public long? ChatMessagesAlliance { get; set; }

    /// <summary>
    /// chat_messages_constellation integer
    /// </summary>
    /// <value>chat_messages_constellation integer</value>
    [DataMember(Name="chat_messages_constellation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chat_messages_constellation")]
    public long? ChatMessagesConstellation { get; set; }

    /// <summary>
    /// chat_messages_corporation integer
    /// </summary>
    /// <value>chat_messages_corporation integer</value>
    [DataMember(Name="chat_messages_corporation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chat_messages_corporation")]
    public long? ChatMessagesCorporation { get; set; }

    /// <summary>
    /// chat_messages_fleet integer
    /// </summary>
    /// <value>chat_messages_fleet integer</value>
    [DataMember(Name="chat_messages_fleet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chat_messages_fleet")]
    public long? ChatMessagesFleet { get; set; }

    /// <summary>
    /// chat_messages_region integer
    /// </summary>
    /// <value>chat_messages_region integer</value>
    [DataMember(Name="chat_messages_region", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chat_messages_region")]
    public long? ChatMessagesRegion { get; set; }

    /// <summary>
    /// chat_messages_solarsystem integer
    /// </summary>
    /// <value>chat_messages_solarsystem integer</value>
    [DataMember(Name="chat_messages_solarsystem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chat_messages_solarsystem")]
    public long? ChatMessagesSolarsystem { get; set; }

    /// <summary>
    /// chat_messages_warfaction integer
    /// </summary>
    /// <value>chat_messages_warfaction integer</value>
    [DataMember(Name="chat_messages_warfaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chat_messages_warfaction")]
    public long? ChatMessagesWarfaction { get; set; }

    /// <summary>
    /// chat_total_message_length integer
    /// </summary>
    /// <value>chat_total_message_length integer</value>
    [DataMember(Name="chat_total_message_length", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chat_total_message_length")]
    public long? ChatTotalMessageLength { get; set; }

    /// <summary>
    /// direct_trades integer
    /// </summary>
    /// <value>direct_trades integer</value>
    [DataMember(Name="direct_trades", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direct_trades")]
    public long? DirectTrades { get; set; }

    /// <summary>
    /// fleet_broadcasts integer
    /// </summary>
    /// <value>fleet_broadcasts integer</value>
    [DataMember(Name="fleet_broadcasts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fleet_broadcasts")]
    public long? FleetBroadcasts { get; set; }

    /// <summary>
    /// fleet_joins integer
    /// </summary>
    /// <value>fleet_joins integer</value>
    [DataMember(Name="fleet_joins", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fleet_joins")]
    public long? FleetJoins { get; set; }

    /// <summary>
    /// mails_received integer
    /// </summary>
    /// <value>mails_received integer</value>
    [DataMember(Name="mails_received", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mails_received")]
    public long? MailsReceived { get; set; }

    /// <summary>
    /// mails_sent integer
    /// </summary>
    /// <value>mails_sent integer</value>
    [DataMember(Name="mails_sent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mails_sent")]
    public long? MailsSent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdStatsSocial {\n");
      sb.Append("  AddContactBad: ").Append(AddContactBad).Append("\n");
      sb.Append("  AddContactGood: ").Append(AddContactGood).Append("\n");
      sb.Append("  AddContactHigh: ").Append(AddContactHigh).Append("\n");
      sb.Append("  AddContactHorrible: ").Append(AddContactHorrible).Append("\n");
      sb.Append("  AddContactNeutral: ").Append(AddContactNeutral).Append("\n");
      sb.Append("  AddNote: ").Append(AddNote).Append("\n");
      sb.Append("  AddedAsContactBad: ").Append(AddedAsContactBad).Append("\n");
      sb.Append("  AddedAsContactGood: ").Append(AddedAsContactGood).Append("\n");
      sb.Append("  AddedAsContactHigh: ").Append(AddedAsContactHigh).Append("\n");
      sb.Append("  AddedAsContactHorrible: ").Append(AddedAsContactHorrible).Append("\n");
      sb.Append("  AddedAsContactNeutral: ").Append(AddedAsContactNeutral).Append("\n");
      sb.Append("  CalendarEventCreated: ").Append(CalendarEventCreated).Append("\n");
      sb.Append("  ChatMessagesAlliance: ").Append(ChatMessagesAlliance).Append("\n");
      sb.Append("  ChatMessagesConstellation: ").Append(ChatMessagesConstellation).Append("\n");
      sb.Append("  ChatMessagesCorporation: ").Append(ChatMessagesCorporation).Append("\n");
      sb.Append("  ChatMessagesFleet: ").Append(ChatMessagesFleet).Append("\n");
      sb.Append("  ChatMessagesRegion: ").Append(ChatMessagesRegion).Append("\n");
      sb.Append("  ChatMessagesSolarsystem: ").Append(ChatMessagesSolarsystem).Append("\n");
      sb.Append("  ChatMessagesWarfaction: ").Append(ChatMessagesWarfaction).Append("\n");
      sb.Append("  ChatTotalMessageLength: ").Append(ChatTotalMessageLength).Append("\n");
      sb.Append("  DirectTrades: ").Append(DirectTrades).Append("\n");
      sb.Append("  FleetBroadcasts: ").Append(FleetBroadcasts).Append("\n");
      sb.Append("  FleetJoins: ").Append(FleetJoins).Append("\n");
      sb.Append("  MailsReceived: ").Append(MailsReceived).Append("\n");
      sb.Append("  MailsSent: ").Append(MailsSent).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}

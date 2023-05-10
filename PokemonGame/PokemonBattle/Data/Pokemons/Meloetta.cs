using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Meloetta : Pokemon
{
	public override string Name => "Meloetta";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Serenegrace() };
	public override Stats BaseStats => new Stats(100, 77, 77, 128, 128, 90);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Round(), new Moves.Quickattack(), new Moves.Confusion(), new Moves.Sing() },
		[6] = new List<Move>() { new Moves.Quickattack() },
		[11] = new List<Move>() { new Moves.Confusion() },
		[16] = new List<Move>() { new Moves.Sing() },
		[21] = new List<Move>() { new Moves.Teeterdance() },
		[26] = new List<Move>() { new Moves.Acrobatics() },
		[31] = new List<Move>() { new Moves.Psybeam() },
		[36] = new List<Move>() { new Moves.Echoedvoice() },
		[43] = new List<Move>() { new Moves.Uturn() },
		[50] = new List<Move>() { new Moves.Wakeupslap() },
		[57] = new List<Move>() { new Moves.Psychic() },
		[64] = new List<Move>() { new Moves.Hypervoice() },
		[71] = new List<Move>() { new Moves.Roleplay() },
		[78] = new List<Move>() { new Moves.Closecombat() },
		[85] = new List<Move>() { new Moves.Perishsong() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Allyswitch(), new Moves.Brickbreak(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Covet(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Dualchop(), new Moves.Echoedvoice(), new Moves.Embargo(), new Moves.Energyball(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gravity(), new Moves.Healbell(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icepunch(), new Moves.Knockoff(), new Moves.Laserfocus(), new Moves.Lastresort(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Magiccoat(), new Moves.Magicroom(), new Moves.Payback(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Relicsong(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Roleplay(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Telekinesis(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Toxic(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Wonderroom(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 65;
	public override int ExpYield => 300;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 1
	};
}
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Gallade : Pokemon
{
	public override string Name => "Gallade";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Steadfast() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Justified() };
	public override Stats BaseStats => new Stats(68, 125, 65, 65, 115, 80);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Slash() },
		[1] = new List<Move>() { new Moves.Slash(), new Moves.Nightslash(), new Moves.Growl(), new Moves.Disarmingvoice(), new Moves.Hypnosis(), new Moves.Drainingkiss(), new Moves.Imprison(), new Moves.Psybeam(), new Moves.Lifedew(), new Moves.Charm(), new Moves.Calmmind(), new Moves.Psychic(), new Moves.Dreameater(), new Moves.Futuresight(), new Moves.Leer(), new Moves.Furycutter(), new Moves.Doubleteam(), new Moves.Confusion() },
		[9] = new List<Move>() { new Moves.Helpinghand() },
		[12] = new List<Move>() { new Moves.Feint() },
		[15] = new List<Move>() { new Moves.Teleport() },
		[18] = new List<Move>() { new Moves.Aerialace() },
		[23] = new List<Move>() { new Moves.Falseswipe() },
		[28] = new List<Move>() { new Moves.Protect() },
		[35] = new List<Move>() { new Moves.Swordsdance() },
		[42] = new List<Move>() { new Moves.Psychocut() },
		[49] = new List<Move>() { new Moves.Healpulse() },
		[56] = new List<Move>() { new Moves.Quickguard(), new Moves.Wideguard() },
		[63] = new List<Move>() { new Moves.Closecombat() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Airslash(), new Moves.Allyswitch(), new Moves.Attract(), new Moves.Aurasphere(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Cut(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Earthquake(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Firepunch(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Leafblade(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Magicalleaf(), new Moves.Magicroom(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Mistyterrain(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychocut(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarblade(), new Moves.Stoneedge(), new Moves.Storedpower(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Tripleaxel(), new Moves.Willowisp(), new Moves.Wonderroom(), new Moves.Workup(), new Moves.Xscissor(), new Moves.Zenheadbutt() };
	public override int Weight => 520;
	public override int ExpYield => 259;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 3,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Absol : Pokemon
{
	public override string Name => "Absol";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure(), new Abilities.Superluck() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Justified() };
	public override Stats BaseStats => new Stats(65, 130, 60, 75, 60, 75);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Quickattack(), new Moves.Leer() },
		[5] = new List<Move>() { new Moves.Doubleteam() },
		[10] = new List<Move>() { new Moves.Knockoff() },
		[15] = new List<Move>() { new Moves.Detect() },
		[20] = new List<Move>() { new Moves.Taunt() },
		[25] = new List<Move>() { new Moves.Slash() },
		[30] = new List<Move>() { new Moves.Nightslash() },
		[35] = new List<Move>() { new Moves.Focusenergy() },
		[40] = new List<Move>() { new Moves.Suckerpunch() },
		[45] = new List<Move>() { new Moves.Swordsdance() },
		[50] = new List<Move>() { new Moves.Futuresight() },
		[55] = new List<Move>() { new Moves.Perishsong() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Airslash(), new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Brutalswing(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Closecombat(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Focusenergy(), new Moves.Foulplay(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Megahorn(), new Moves.Payback(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychocut(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Waterpulse(), new Moves.Willowisp(), new Moves.Xscissor(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Assurance(), new Moves.Batonpass(), new Moves.Bite(), new Moves.Curse(), new Moves.Doubleedge(), new Moves.Feint(), new Moves.Hex(), new Moves.Magiccoat(), new Moves.Meanlook(), new Moves.Megahorn(), new Moves.Perishsong(), new Moves.Playrough(), new Moves.Suckerpunch(), new Moves.Zenheadbutt() };
	public override int Weight => 470;
	public override int ExpYield => 163;
	public override int CatchRate => 30;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}
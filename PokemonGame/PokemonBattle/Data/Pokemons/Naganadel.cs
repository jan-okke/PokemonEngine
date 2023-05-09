using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Naganadel : Pokemon
{
	public override string Name => "Naganadel";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Beastboost() };
	public override Stats BaseStats => new Stats(73, 73, 73, 127, 73, 121);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Aircutter() },
		[1] = new List<Move>() { new Moves.Aircutter(), new Moves.Airslash(), new Moves.Dragonpulse(), new Moves.Peck(), new Moves.Growl(), new Moves.Helpinghand(), new Moves.Acid() },
		[7] = new List<Move>() { new Moves.Furyattack() },
		[14] = new List<Move>() { new Moves.Fellstinger() },
		[21] = new List<Move>() { new Moves.Charm() },
		[28] = new List<Move>() { new Moves.Venoshock() },
		[35] = new List<Move>() { new Moves.Venomdrench() },
		[42] = new List<Move>() { new Moves.Nastyplot() },
		[49] = new List<Move>() { new Moves.Poisonjab() },
		[56] = new List<Move>() { new Moves.Gastroacid() },
		[63] = new List<Move>() { new Moves.Toxic() },
		[70] = new List<Move>() { new Moves.Dragonrush() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Airslash(), new Moves.Allyswitch(), new Moves.Assurance(), new Moves.Breakingswipe(), new Moves.Charm(), new Moves.Crosspoison(), new Moves.Darkpulse(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Fly(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Leechlife(), new Moves.Nastyplot(), new Moves.Outrage(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Scaleshot(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Smartstrike(), new Moves.Snarl(), new Moves.Snore(), new Moves.Spikes(), new Moves.Substitute(), new Moves.Swift(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderbolt(), new Moves.Toxicspikes(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Xscissor() };
	public override int Weight => 1500;
	public override int ExpYield => 270;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}
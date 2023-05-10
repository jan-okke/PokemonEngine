using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Arceus : Pokemon
{
	public override string Name => "Arceus";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Multitype() };
	public override Stats BaseStats => new Stats(120, 120, 120, 120, 120, 120);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Seismictoss(), new Moves.Cosmicpower() },
		[10] = new List<Move>() { new Moves.Gravity() },
		[20] = new List<Move>() { new Moves.Earthpower() },
		[30] = new List<Move>() { new Moves.Hypervoice() },
		[40] = new List<Move>() { new Moves.Extremespeed() },
		[50] = new List<Move>() { new Moves.Healingwish() },
		[60] = new List<Move>() { new Moves.Futuresight() },
		[70] = new List<Move>() { new Moves.Recover() },
		[80] = new List<Move>() { new Moves.Hyperbeam() },
		[90] = new List<Move>() { new Moves.Perishsong() },
		[100] = new List<Move>() { new Moves.Judgment() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Aquatail(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Bulletseed(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Defog(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragonpulse(), new Moves.Dreameater(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Flashcannon(), new Moves.Fly(), new Moves.Focusblast(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gravity(), new Moves.Hail(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Laserfocus(), new Moves.Lastresort(), new Moves.Lightscreen(), new Moves.Liquidation(), new Moves.Magiccoat(), new Moves.Outrage(), new Moves.Overheat(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Quash(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snarl(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Tailwind(), new Moves.Telekinesis(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Willowisp(), new Moves.Workup(), new Moves.Xscissor(), new Moves.Zenheadbutt() };
	public override int Weight => 3200;
	public override int ExpYield => 360;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 3,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}